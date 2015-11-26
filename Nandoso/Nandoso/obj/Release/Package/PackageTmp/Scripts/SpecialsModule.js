var SpecialsModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getSpecials: function (callback) {
            console.log("this was called from SpecialsModule");

            $.ajax({
                type: "GET",
                dataType: "json",
                url: "https://nandosojosiahm.azurewebsites.net/api/specials",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());