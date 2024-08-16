# La Veterinaria 1

Este proyecto fue desarrollado por [Benjamín Sandí](https://github.com/FierceSpectrum) y [Josafat Ramírez](https://github.com/Josafath17) durante el primer cuatrimestre del año 2023 como parte de su aprendizaje en desarrollo de software utilizando C#. El proyecto "La Veterinaria 1" es una aplicación de escritorio que gestiona la información de una veterinaria, incluyendo clientes, mascotas, enfermedades y medicamentos.

## Descripción del Proyecto

"La Veterinaria 1" es un sistema diseñado para facilitar la gestión de una veterinaria. La aplicación permite al personal de la veterinaria llevar un registro detallado de clientes, mascotas, enfermedades y medicamentos.

### Características Principales

- **Clientes:** El sistema permite crear, leer, actualizar y eliminar (CRUD) registros de clientes. Un cliente puede tener varias mascotas asociadas.
- **Mascotas:** Se pueden gestionar registros de mascotas, cada una asociada a un cliente. Una mascota puede tener varias enfermedades registradas.
- **Enfermedades:** Las enfermedades de las mascotas se registran y gestionan en el sistema. Una enfermedad puede tener varios medicamentos asignados.
- **Medicamentos:** Se pueden registrar medicamentos que están asociados a las enfermedades de las mascotas.
  
### Estructura del Proyecto

El proyecto está compuesto por varios archivos y carpetas generados en Visual Studio, entre ellos:

- **Clínica.cs:** Archivo principal del proyecto, desde donde se maneja la lógica central.
- **CRUD Clientes, CRUD Enfermedades, CRUD Mascotas:** Secciones del proyecto dedicadas a gestionar la información de clientes, enfermedades y mascotas.
- **Archivos .resx:** Recursos utilizados en la aplicación, como cadenas de texto y otros elementos.
- **Archivos .csproj y .sln:** Archivos de configuración del proyecto en Visual Studio.
- **Carpeta `bin/Debug` y `obj/Debug`:** Directorios de compilación generados por Visual Studio.

### Tecnologías Utilizadas

- **Lenguaje de Programación:** C# (C-Sharp).
- **Entorno de Desarrollo:** Visual Studio.
- **Patrón de Diseño:** Se utilizó el enfoque basado en clases para la estructura del sistema.
- **Archivos de Estilos:** Aunque es un proyecto de escritorio, incluye archivos CSS y otros recursos de diseño.

## Ejecución del Proyecto

Debido a la naturaleza del proyecto y a las herramientas utilizadas en su creación, para ejecutar "La Veterinaria 1" es necesario:

1. Tener Visual Studio instalado en la máquina.
2. Clonar el repositorio en la máquina local utilizando el siguiente comando:
    ```bash
    git clone https://github.com/FierceSpectrum/LaVeterinaria1
    ```
3. Abrir el archivo de solución (`LaVeterinaria1.sln`) en Visual Studio.
4. Compilar y ejecutar el proyecto desde Visual Studio.

## Estado del Proyecto

Este proyecto fue creado como una práctica educativa durante el primer cuatrimestre del año 2023. Actualmente, no se han realizado actualizaciones desde su creación, y es considerado un proyecto de aprendizaje.

## Licencia

Este proyecto no tiene una licencia formal. Fue creado con fines educativos y no está destinado para uso comercial. Los desarrolladores son estudiantes que están aprendiendo y mejorando sus habilidades en el desarrollo de software.
