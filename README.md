# Platform Security Project

A full-stack project demonstrating a .NET 8 Web API and an Angular single-page website for loan management, containerised with Docker and deployed on Kubernetes. This repository illustrates the end-to-end process from development in your IDE through to containerisation and local Kubernetes deployment, all within the AWS free tier.

---

## Table of Contents

- [Overview](#overview)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Setup Instructions](#setup-instructions)
  - [Prerequisites](#prerequisites)
  - [Local Setup](#local-setup)
    - [.NET API](#net-api)
    - [Angular Website](#angular-website)
- [Docker Instructions](#docker-instructions)
  - [.NET API](#net-api-docker)
  - [Angular Website](#angular-website-docker)
- [Kubernetes Deployment](#kubernetes-deployment)
- [Interview Preparation / Presentation](#interview-preparation--presentation)
- [License](#license)
- [Contact](#contact)

---

## Overview

This repository provides a complete demonstration of a modern full-stack solution. It consists of:

- A **.NET 8 Web API** for managing loan data, using an in-memory data store.
- An **Angular SPA** that provides a user interface for interacting with the API.
- **Docker** containerisation for both the API and the website.
- A **Kubernetes** configuration for local deployment (using Minikube or KinD), with the potential to extend to AWS EKS.
- All components are developed within the AWS free tier constraints.

---

## Project Structure

PlatformSecurityProject/
├── LoanApi/
│   ├── LoanApi.sln
│   ├── LoanApi/
│   │   ├── Controllers/         # API controllers for loan management
│   │   ├── Data/                # In-memory data store (e.g., LoanRepository.cs)
│   │   ├── Models/              # Data models (e.g., Loan.cs)
│   │   ├── Program.cs           # Application entry point
│   │   ├── appsettings.json     # Configuration settings
│   │   └── Dockerfile           # Dockerfile for containerising the API
│   └── README.md                # (Optional) API-specific documentation
├── PlatformSecurityWebsite/
│   └── LoanWebsite/
│       ├── angular.json         # Angular workspace configuration
│       ├── package.json         # Node.js project configuration
│       ├── src/
│       │   ├── app/             # Angular components, services, modules
│       │   ├── assets/          # Static assets (images, styles, etc.)
│       │   ├── environments/    # Environment configuration files
│       │   │   ├── environment.ts
│       │   │   └── environment.prod.ts
│       │   ├── index.html       # Main HTML file
│       │   ├── main.ts          # Application bootstrap
│       │   ├── polyfills.ts     # Polyfills required for Angular
│       │   └── styles.css       # Global styles
│       └── Dockerfile           # Dockerfile for containerising the Angular app
├── k8s-deployment.yaml          # Kubernetes manifest for both API and website
└── README.md                    # Global project README


---

## Technologies Used

- **Backend:** .NET 8 Web API
- **Frontend:** Angular SPA
- **Containerisation:** Docker
- **Orchestration:** Kubernetes (Minikube/KinD)
- **Cloud:** AWS (Free Tier)
- **Development Tools:** Your preferred IDE (e.g., VS Code, WebStorm, PyCharm), Git, npm

---

## Setup Instructions

### Prerequisites

- **.NET 8 SDK**
- **Node.js** and **npm**
- **Angular CLI** (install with `npm install -g @angular/cli`)
- **Docker** (Docker Desktop is recommended)
- **Kubernetes Tools:** Minikube or KinD
- **Git**

### Local Setup

#### .NET API

1. **Navigate to the API directory:**
   ```bash
   cd "C:\Projects\PlatformSecurityProject\LoanApi\LoanApi"
2. Restore and run the API:
   `dotnet restore
   dotnet run`
3. Test API endpoints (e.g., POST, GET, DELETE) at:
   http://localhost:5000/api/Loan

Angular Website
1. Navigate to the Angular project folder:
`cd "C:\Projects\PlatformSecurityProject\PlatformSecurityWebsite\LoanWebsite"`

2. Install dependencies:
`npm install`

3. Build the Angular app for production:
   `npm run build -- --configuration production`

_Alternatively_
   `ng build --configuration production`

4. (Optional) Serve locally for development:
   `ng serve`

5. Test the Angular app.

   The app will be available at:
   http://localhost:4200

## Docker Instructions

### .NET API Docker

1. Navigate to the API directory:

`cd "C:\Projects\PlatformSecurityProject\LoanApi\LoanApi"`
2. Build the Docker image:

`docker build -t platform-security-api .`
3. Run the container:

`docker run -d -p 5000:80 platform-security-api`


## Angular Website Docker

1. Navigate to the Angular project folder:

`cd "C:\Projects\PlatformSecurityProject\PlatformSecurityWebsite\LoanWebsite"`

2. Build the Docker image:

`docker build -t loanwebsite .`

3. Run the container:

`docker run -d -p 4200:80 loanwebsite`

Open your browser at:
http://localhost:4200


## Kubernetes Deployment

1. Ensure your local Kubernetes cluster is running (e.g., start Minikube):

`minikube start`

2. Deploy the applications using the manifest:

`kubectl apply -f k8s-deployment.yaml`

3. Check the deployment:

`kubectl get deployments
kubectl get services`

Access the application via the assigned NodePort or Minikube IP.

## License
This project is licensed under the [MIT License](LICENSE).

## Contact
For any questions or further information, please contact:

David Levi

GitHub: https://github.com/basedzen

Email: [d.b.levi@outlook.com]()
