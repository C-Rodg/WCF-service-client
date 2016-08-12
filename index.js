var num1 = 606060609,
	num2 = 7325;
var fs = require('fs');

// WSHttpBinding example with client and server certificate
var WSHttpBinding = require('wcf.js').WSHttpBinding
	, Proxy = require('wcf.js').Proxy
	, binding = new WSHttpBinding({
		 SecurityMode : "Message"
		,MessageClientCredentialType : "Certificate"
	})
	, proxy = new Proxy(binding, "http://localhost:62665/Calculator.svc")
	, message = `<Envelope xmlns="http://schemas.xmlsoap.org/soap/envelope/">
					<Header />
						<Body>
							<SubtractNumbers xmlns="http://validar.com/Vaf/AccountService">
									<num1>${num1}</num1>
									<num2>${num2}</num2>
							</SubtractNumbers>
						</Body>
				</Envelope>`;

proxy.ClientCredentials.ClientCertificate.Certificate = fs.readFileSync("path/to/ClientCertificate.pem").toString();
proxy.ClientCredentials.ServiceCertificate.DefaultCertificate = fs.readFileSync("path/to/ServiceCertificate.pem").toString();

proxy.send(message, "http://tempuri.org/ICalculator/SubtractNumbers", function(response, ctx) {
	// Do something with response
});


// BasicHttpBinding example
var BasicHttpBinding = require('wcf.js').BasicHttpBinding
	, Proxy = require('wcf.js').Proxy
	, binding = new BasicHttpBinding()
	, proxy = new Proxy(binding, "http://localhost:62665/Calculator.svc")
	, message = `<Envelope xmlns="http://schemas.xmlsoap.org/soap/envelope/"><Header /><Body>
					<SubtractNumbers xmlns="http://tempuri.org/">
						<num1>${num1}</num1>
						<num2>${num2}</num2>
					</SubtractNumbers></Body></Envelope>`;

proxy.send(message, "http://tempuri.org/ICalculator/SubtractNumbers", function(response, ctx) {
	// Do something with response
});