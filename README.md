# SMTPSender - C# SMTP Client Test Project

## Project Description

SMTPSender is a C# test project demonstrating the use of the SMTP Client to send emails via Gmail. This project utilizes the Singleton design pattern and follows the MVC (Model-View-Controller) pattern.

## Project Structure

The project is organized as follows:

- **Controllers:** Contains the logic for sending emails (`EmailSender`).
- **Models:** Contains the necessary model classes for email sending (`Email`, `EmailAttachment`, `EmailCredentials`).
- **Utils:** Contains utilities such as converters, validations, and a logger (`Converters`, `Validations`, `Logger`).
- **Views:** Contains user interface views (`CredentialsModal`, `SMTPSender`).

## How to Use

1. **Credentials:**
   - Run the application.
   - Click the "Credentials" button to enter your Gmail email account information.
   - A modal window (`CredentialsModal`) will open where you should provide your email address and password.
   - Once credentials are entered, click "Save."

2. **Sending Emails:**
   - After entering credentials, the section for composing emails (`SMTPSender`) will be enabled.
   - Enter the recipient, subject, and body of the email.
   - You can attach files by clicking "Add Attachments" and selecting the desired files.
   - Click "Send Email" to send the email.

3. **Activity Log:**
   - All activities, including errors and successes, are logged in a log file (`log.txt`) using the `Logger` component.

## Requirements and Dependencies

- .NET Framework (the version used in this project).
- Permissions to access the Gmail email account.

## Important Notes

- Ensure not to share your credentials with anyone.
- This project is an educational and test example.

## License

This project is under the [MIT License](LICENSE).

---

# SMTPSender - Proyecto de prueba de SMTP Client en C

## Descripción del Proyecto

SMTPSender es un proyecto de prueba en C# que demuestra el uso del Cliente SMTP para enviar correos electrónicos a través de Gmail. Este proyecto utiliza el patrón de diseño Singleton y sigue el modelo MVC (Modelo-Vista-Controlador).

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

- **Controllers:** Contiene la lógica del envío de correos electrónicos (`EmailSender`).
- **Models:** Contiene las clases de modelos necesarias para el envío de correos (`Email`, `EmailAttachment`, `EmailCredentials`).
- **Utils:** Contiene utilidades como convertidores, validaciones y un registrador (`Converters`, `Validations`, `Logger`).
- **Views:** Contiene las vistas de la interfaz de usuario (`CredentialsModal`, `SMTPSender`).

## Cómo Usar

1. **Credenciales:**
   - Ejecute la aplicación.
   - Haga clic en el botón "Credenciales" para ingresar la información de su cuenta de correo electrónico de Gmail.
   - Se abrirá una ventana modal (`CredentialsModal`) donde deberá proporcionar su dirección de correo electrónico y contraseña.
   - Una vez ingresadas las credenciales, haga clic en "Guardar".

2. **Envío de Correos:**
   - Después de ingresar las credenciales, se habilitará la sección para redactar correos (`SMTPSender`).
   - Ingrese el destinatario, asunto y cuerpo del correo.
   - Puede adjuntar archivos haciendo clic en "Agregar Adjuntos" y seleccionando los archivos deseados.
   - Haga clic en "Enviar Correo" para enviar el correo electrónico.

3. **Registro de Actividad:**
   - Todas las actividades, incluidos errores y éxitos, se registran en un archivo de registro (`log.txt`) gracias al componente `Logger`.

## Requisitos y Dependencias

- .NET Framework (la versión utilizada en este proyecto).
- Permisos de acceso a la cuenta de correo electrónico de Gmail.

## Notas Importantes

- Asegúrese de no compartir sus credenciales con nadie.
- Este proyecto es un ejemplo educativo y de prueba.

## Licencia

Este proyecto está bajo la [Licencia MIT](LICENSE).
