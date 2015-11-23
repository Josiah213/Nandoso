var SpecialsModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getSpecials: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://nandosojosiahm.azurewebsites.net/api/special",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());