# Documentacion TorneoManager

Sistema de gestion de ligas y torneos de futbol amateur construido con Windows Forms (.NET 9) y Oracle (PL/SQL).

- Capas: Dominio (modelos/contratos), Entity (ADO.NET Oracle), Logic (servicios), Presentacion (WinForms), database/ (DDL, vistas, paquetes PL/SQL y datos de ejemplo).
- Persistencia en Oracle via `Oracle.ManagedDataAccess.Core`; cadena en `TorneoManager.Entity/DBContext.cs`.
- UI principal: `FrmMenuPrincipal` navega a gestion de torneos, equipos, jugadores, fixture/resultados, proximos partidos y reportes (tabla, goleadores, sanciones, fair play).

## Requisitos rapidos
- .NET 9 SDK y Windows para WinForms.
- Oracle DB (XE es suficiente). Ejecutar los scripts SQL en el orden sugerido.
- Ajustar cadena de conexion (`DBContext._connectionString`) antes de correr.

## Ejecucion
1) Crear base de datos (ver seccion siguiente).  
2) `dotnet restore` (si hace falta).  
3) `dotnet run --project TorneoManager.Presentacion` abre el menu principal.

## Base de datos (Oracle)
Scripts en `database/` pensados para ejecutarse en orden:

1. `01_schema.sql`: tablas basicas (TORNEO, EQUIPO, JUGADOR, PARTIDO, POSICION, TARJETA, SANCION_JUGADOR, AUDITORIA_PARTIDO) e indices.
2. `02_views.sql`: vista de tabla de posiciones (`V_TABLA_POSICIONES`), tabla de alineacion por partido (`PARTIDO_JUGADOR`), goleadores (`V_GOLEADORES`), sancionados (`V_JUGADORES_SANCIONADOS`) y fair play (`V_FAIR_PLAY`).
3. `03_packages.sql`: paquete `PKG_TORNEO` (registrar resultado, inicializar y recalcular posiciones) y `PKG_TARJETAS` (registrar tarjeta, evaluar sancion). Incluye auditoria al actualizar resultados.
4. `04_triggers.sql`: inserta filas en POSICION al crear equipos; trigger de update de partido (solo auditoria, recalculo se hace via paquete).
5. `05_update_schema.sql`: agrega formaciones a PARTIDO y crea tabla GOL.
6. `06_seed.sql`: datos de demostracion no idempotentes (dos torneos, equipos, jugadores, partidos jugados, goles, tarjetas, sanciones). Ejecuta `PKG_TORNEO` para recalcular posiciones.
7. `07_feature_extensions.sql`: extensiones (categoria/division y ascensos/descensos, sedes/bloqueos, arbitros y designaciones, reprogramaciones, estadisticas enriquecidas, apelaciones). Agrega vistas de arbitrajes y eventos.
8. `08_seed_safe.sql`: carga de ejemplo idempotente (torneo demo, equipos Alpha/Beta, sede, arbitro, partido con goles/tarjeta, reprogramacion, eventos, racha, sancion y apelacion).

### Tablas clave (resumen)
- TORNEO: reglas de puntos y suspensiones, categoria/division, estado.
- EQUIPO, JUGADOR: pertenencia a torneo/equipo, estado activo.
- PARTIDO: programacion, marcador, estado, sede y formaciones.
- POSICION: tabla calculada por paquete; primaria (id_torneo,id_equipo).
- GOL, TARJETA: eventos del partido.
- SANCION_JUGADOR y APELACION: disciplina, fechas y apelaciones.
- SEDE, SEDE_BLOQUEO: sedes y fechas no disponibles.
- ARBITRO, PARTIDO_ARBITRAJE: designaciones y calificacion.
- PARTIDO_REPROGRAMACION: historial de cambios de fecha.
- PARTIDO_EVENTO_JUGADOR y RACHA_EQUIPO: estadistica avanzada por jugador/equipo.
- ASCENSO_DESCENSO: movimientos entre torneos.

### Vistas y paquetes
- `V_TABLA_POSICIONES`, `V_GOLEADORES`, `V_JUGADORES_SANCIONADOS`, `V_FAIR_PLAY`, `V_ARBITROS_POR_PARTIDO`, `V_EVENTOS_PARTIDO`.
- `PKG_TORNEO.registrar_resultado` actualiza marcador, audita y recalcula posiciones (respetando puntos configurados).
- `PKG_TARJETAS.registrar_tarjeta` crea tarjeta y genera sanciones (por roja directa o acumulacion de amarillas segun regla del torneo).

## Capas y flujo
- **Dominio** (`TorneoManager.Dominio`): clases POCO (Torneo, Equipo, Jugador, Partido, Gol, Tarjeta, Posicion, Goleador, SancionJugador, FairPlayEntry, Arbitro, Sede, PartidoReprogramacion, PartidoArbitraje, PartidoEventoJugador, RachaEquipo, Apelacion) y contratos de repositorio.
- **Entity** (`TorneoManager.Entity`): implementaciones ADO.NET sobre Oracle. Repositorios llaman SQL directo o stored procedures (`PKG_TORNEO`, `PKG_TARJETAS`). `DBContext` expone conexion y permite fijar cadena en tiempo de ejecucion.
- **Logic** (`TorneoManager.Logic`): servicios finos que orquestan repositorios (CRUD torneos/equipos/jugadores, programacion y resultados de partidos, registro de goles/tarjetas, reportes, arbitros, sedes, reprogramaciones y estadisticas).
- **Presentacion** (`TorneoManager.Presentacion`): WinForms y tema visual centralizado en `Tema.cs`. El menu principal aloja forms hijos sin bordes dentro de un panel.
- **database**: scripts para crear/sembrar Oracle.

## Servicios principales (Logic)
- `GestionTorneosService`: listar, guardar, desactivar torneos.
- `GestionEquiposService`: CRUD de equipos por torneo.
- `GestionJugadoresService`: carga masiva/CRUD de jugadores por equipo.
- `GestionPartidosService`: programar/editar partidos, registrar resultado (usa `PKG_TORNEO`), registrar/listar goles y tarjetas.
- `ReportesService`: tabla de posiciones, goleadores, sancionados, fair play (vistas).
- `CalendarioAvanzadoService`: reprogramaciones, designacion de arbitros y calificaciones.
- `ArbitrosService`, `SedesService`: altas/ediciones basicas.
- `EstadisticasExtendidasService`: eventos de jugador (minutos, asistencias, xG, MVP) y rachas de equipo.

## Formularios (Presentacion)
- `FrmMenuPrincipal`: contenedor de panel; aplica tema; abre por defecto proximos partidos.
- `FrmGestionTorneos`: CRUD sencillo; usa `GestionTorneosService`.
- `FrmGestionEquipos`: selecciona torneo, CRUD de equipos y estado activo.
- `FrmGestionJugadores`: selecciona torneo/equipo, edicion masiva de hasta 15 filas (titulares/suplentes), guarda via `GestionJugadoresService`.
- `FrmFixture`: gestiona programacion, formaciones y sede; asigna arbitro; registra resultado; abre modales de goles/tarjetas; permite reprogramar guardando historial y reusando ProgramarPartido.
- `FrmRegistroGoles` / `FrmRegistroTarjetas`: modales por partido, filtran jugadores por equipo y guardan eventos.
- `FrmProximosPartidos`: pestañas por torneo, lista partidos programados ordenados por fecha.
- `FrmTablaPosiciones`: pestañas de posiciones, goleadores, sanciones y fair play; recarga con `ReportesService`.

## Notas de configuracion
- Cadena de conexion por defecto: `User Id=system;Password=oracle;Data Source=localhost:1521/xepdb1;` en `TorneoManager.Entity/DBContext.cs`. Cambiarla antes de ejecutar; se puede exponer setter `DBContext.SetConnectionString(...)` en arranque.
- Si se omite ejecutar `03_packages.sql`, registrar resultados y tarjetas fallara porque los servicios usan esos procedimientos.
- `06_seed.sql` asume esquema vacio; use `08_seed_safe.sql` para cargas repetibles.

## Flujo funcional resumido
1. Crear torneo -> Equipos -> Jugadores.  
2. Programar partidos (sede, formacion, arbitro) en `FrmFixture`.  
3. Registrar goles/tarjetas; al guardar resultados se recalcula `POSICION` via paquete.  
4. Consultar proximos partidos o reportes (tabla/goleadores/sanciones/fair play).  
5. Opcional: reprogramar partidos, registrar eventos avanzados o designar arbitros/estadios adicionales.

## Estructura de la solucion
- `TorneoManager.sln` con proyectos:
  - `TorneoManager.Dominio` (net9.0)
  - `TorneoManager.Entity` (net9.0, referencia a Oracle.ManagedDataAccess.Core 23.26.0)
  - `TorneoManager.Logic` (net9.0)
  - `TorneoManager.Presentacion` (net9.0-windows, WinExe)
- Recursos de diseño `.Designer.cs`/`.resx` se mantienen bajo `TorneoManager.Presentacion`.
