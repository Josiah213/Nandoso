var SpecialsModule = (function () {
    return {
        getSpecials: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://api.uinames.com/?amount=25", //need to check the url for this that gets specials
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());