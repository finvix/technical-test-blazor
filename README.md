# Prueba Técnica: Desarrollador Blazor

## Contexto

Finvix necesita un módulo de gestión de contactos. Tu tarea es completarlo usando Blazor Server Side, demostrando conocimientos en componentización, JS Interop y arquitectura.

---

## Recursos disponibles

### Proyecto Blazor (`/Finvix.Contacts/`)

El proyecto ya tiene la estructura base:

- **Modelo**: `/Models/Contact.cs` con las propiedades Id, Nombre, Email, Ciudad, Mensaje, CreatedAt y UpdatedAt
- **Páginas**: `/Components/Pages/Contacts/` con Lista.razor, Crear.razor y Editar.razor (estructura básica sin funcionalidad)
- **Layout**: `/Components/Layout/MainLayout.razor` (template por defecto de Blazor)

### Template Vuexy (`/resources/`)

Contiene todos los assets del template Bootstrap 5 Vuexy:

```
/resources/
├── assets/          → CSS y JS compilados del template
├── libs/            → Librerías JS (jQuery, Select2, etc.)
├── fonts/           → Fuentes e iconos
├── html-examples/   → 146 páginas HTML de ejemplo navegables
└── html-starter/    → Template base limpio
```

**Antes de comenzar**, abre en tu navegador estos archivos para entender el diseño esperado:

1. `resources/html-examples/index.html` → Dashboard general
2. `resources/html-examples/forms-selects.html` → Cómo se ve Select2 funcionando
3. `resources/html-examples/form-layouts-vertical.html` → Estructura de formularios
4. `resources/html-examples/tables-basic.html` → Estructura de tablas
5. `resources/html-starter/index.html` → Template mínimo de referencia

---

## Tareas a completar (en orden)

### Paso 1: Integrar el template Vuexy en Blazor

Debes integrar el template Vuexy en el proyecto `Finvix.Contacts` de Blazor, utilizando como guía la estructura de `resources/html-starter/index.html` y logrando que visualmente se vea como los ejemplos de `resources/html-examples/`.

**Alcance:**
- Copiar los assets necesarios de `/resources/` a `/wwwroot/`
- Modificar el layout para incluir los CSS y JS del template
- Las 3 páginas de contactos deben verse con el estilo Vuexy

### Paso 2: Crear el componente CitySelect

**Este es el requisito principal de la prueba.**

Debes crear un componente reutilizable para seleccionar ciudades que integre la librería Select2.

**Alcance:**
- El componente debe usar la librería Select2 ubicada en `/resources/assets/vendor/libs/select2/`
- Debe implementar JS Interop bidireccional (Blazor llama a JS, JS notifica a Blazor)
- Debe ser reutilizable: usar el mismo componente en Lista (como filtro), Crear y Editar
- El valor seleccionado debe sincronizarse correctamente con el modelo Contact.Ciudad

### Paso 3: Implementar el servicio de contactos

Debes crear un servicio mock que maneje los contactos en memoria.

**Alcance:**
- Crear una interfaz con las operaciones CRUD necesarias
- Implementar el servicio usando una lista en memoria
- Registrar el servicio en el contenedor de dependencias
- Inyectar y usar el servicio en las 3 páginas

---

## Entregable

1. Hacer **fork** de este repositorio
2. Completar las 3 tareas en orden
3. Hacer **push** de tu solución

---

## Documentación de referencia

- [Blazor Server](https://learn.microsoft.com/aspnet/core/blazor)
- [JS Interop en Blazor](https://learn.microsoft.com/aspnet/core/blazor/javascript-interoperability)
- [Select2](https://select2.org/)
