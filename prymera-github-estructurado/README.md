# Prymera Bank - 

Proyecto académico inspirado en la página oficial de Prymera: https://prymera.pe/

## Descripción
Sistema web tipo banco/financiera con frontend en React y backend en ASP.NET Core Web API.

## Módulos principales
- Inicio
- Créditos
- Ahorros
- Canales de pago
- Agencias
- Formulario de contacto
- Login básico de usuario

## Tecnologías
### Frontend
- React
- Vite
- CSS puro
- JavaScript

### Backend
- ASP.NET Core Web API
- C#
- Controllers, Models, DTOs y Utils

## Estr
```txt
prymera-github-estructurado/
├── backend/
│   ├── Controllers/
│   ├── Data/
│   ├── Dtos/
│   ├── Models/
│   ├── Utils/
│   ├── appsettings.json
│   ├── Program.cs
│   └── PrymeraApi.csproj
└── frontend/
    ├── public/
    ├── src/
    │   ├── assets/
    │   ├── components/
    │   ├── pages/
    │   ├── services/
    │   ├── styles/
    │   ├── App.jsx
    │   └── main.jsx
    ├── package.json
    └── vite.config.js
```

## Ejecutar frontend
```bash
cd frontend
npm install
npm run dev
```

## Ejecutar backend
```bash
cd backend
dotnet restore
dotnet run
```

## Nota
Este proyecto es una maqueta académica. No pertenece oficialmente a Prymera.
