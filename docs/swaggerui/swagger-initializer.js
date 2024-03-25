window.onload = function () {
    //<editor-fold desc="Changeable Configuration Block">

    // the following lines will be replaced by docker/configurator, when it runs in a docker-container
    const address = window.location.href.split('#')[0];
    window.ui = SwaggerUIBundle({
        url: address + "../openapi/address.json",
        dom_id: '#swagger-ui',
        deepLinking: true,
        //presets: [
        //  SwaggerUIBundle.presets.apis,
        //  SwaggerUIStandalonePreset
        //],
        //plugins: [
        //  SwaggerUIBundle.plugins.DownloadUrl
        //],
        //layout: "StandaloneLayout"
    });

    //</editor-fold>
};
