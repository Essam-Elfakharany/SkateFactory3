TO ENABLE QR CODES IN IDENTITY:

- Right click the Views folder, Add -> View...
    - In the Add New Scaffolded Item, select "Identity" in the left side, then click "Identity" item, and click Add.
    - In the Add Identity window, check "Account\Manage\EnableAuthenticator". Select the context class and click Add.

- Right click the SkateFactory3.WebUI project, Add -> Client-Side Library...
    - In the dialog box, search for "qrcodejs"
    - Add all qrcodejs library files in the following target location: "wwwroot/lib/qrcodejs/"

- In the Solution Explorer windows, expand "SkateFactory3.WebUI\wwwroot\js\"
    - Right click the js folder, Add -> New Item...
    - Search for "javascript". Select JavaScript File, give the name "qr.js", then click Add.

- In the qr.js file, add the following code:

    window.addEventListener("load", () => {
        const uri = document.getElementById("qrCodeData").getAttribute('data-url');
        new QRCode(document.getElementById("qrCode"),
            {
                text: uri,
                width: 150,
                height: 150
            });
    });

- Open the EnableAuthenticator.cshtml file. Scroll all the way down and make sure you add qrcode.js and qr.js to the Scripts section:

    @section Scripts {
        <partial name="_ValidationScriptsPartial" />

        <script type="text/javascript" src="~/lib/qrcodejs/qrcode.js"></script>
        <script type="text/javascript" src="~/js/qr.js"></script>
    }

- Run the application. 
    - After signing in, navigate to "http://localhost:YOUR_PORT_HERE/Identity/Account/Manage"
    - Select "Two-factor authentication", then "Set up authenticator app"
    - You should see the QR code image now.

SOURCE:
https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-enable-qrcodes?view=aspnetcore-7.0
