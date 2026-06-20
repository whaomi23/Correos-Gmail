# Correos_Gmail

## Descripción

Correos_Gmail es una aplicación de escritorio desarrollada en **C# con Windows Forms** que permite enviar correos electrónicos mediante un servidor SMTP. La aplicación proporciona una interfaz sencilla donde el usuario puede ingresar el destinatario, asunto y contenido del mensaje, además de seleccionar si el correo debe enviarse en formato HTML.

El sistema utiliza autenticación SMTP para conectarse a un servidor de correo y realizar el envío de mensajes de manera automática.

---

## Características

* Envío de correos electrónicos desde una aplicación de escritorio.
* Soporte para mensajes en texto plano.
* Soporte para mensajes en formato HTML.
* Interfaz gráfica sencilla e intuitiva.
* Configuración SMTP mediante credenciales de acceso.
* Validación y manejo de errores durante el envío.

---

## Tecnologías Utilizadas

* C#
* .NET Framework
* Windows Forms
* SMTP
* System.Net.Mail
* Programación Orientada a Objetos (POO)

---

## Funcionamiento

### 1. Ingresar destinatario

El usuario escribe la dirección de correo electrónico a la que desea enviar el mensaje.

Ejemplo:

```text
usuario@correo.com
```

### 2. Escribir asunto

Se captura el asunto del correo.

Ejemplo:

```text
Prueba de envío desde C#
```

### 3. Redactar mensaje

El usuario escribe el contenido que desea enviar.

### 4. Seleccionar formato HTML (Opcional)

Si la casilla está activada, el mensaje será interpretado como código HTML.

Ejemplo:

```html
<h1>Hola Mundo</h1>
<p>Correo enviado desde Windows Forms.</p>
```

### 5. Enviar correo

Al presionar el botón **Enviar**, la aplicación:

* Crea un objeto MailMessage.
* Configura el servidor SMTP.
* Establece las credenciales.
* Envía el correo al destinatario indicado.

---

## Componentes Principales

### MailMessage

Representa el correo electrónico que será enviado.

Propiedades utilizadas:

* Destinatario.
* Asunto.
* Cuerpo del mensaje.
* Formato HTML.

### SmtpClient

Permite conectarse al servidor SMTP y realizar el envío del mensaje.

Configuración:

* Host SMTP.
* Puerto.
* SSL.
* Usuario.
* Contraseña.

---

## Estructura del Proyecto

```text
Correos_Gmail/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Properties/
└── Resources/
```

---

## Funcionalidades Implementadas

* Captura de destinatario.
* Captura de asunto.
* Captura de mensaje.
* Soporte HTML.
* Envío mediante SMTP.
* Mensajes de confirmación.
* Manejo de excepciones.

---

## Objetivo del Proyecto

Demostrar el uso de SMTP en C# mediante una aplicación Windows Forms capaz de enviar correos electrónicos de forma automática desde una interfaz gráfica.

---

## Autor

Proyecto desarrollado en C# utilizando Windows Forms y protocolos SMTP para el envío automatizado de correos electrónicos.
