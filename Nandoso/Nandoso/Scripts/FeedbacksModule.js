var FeedbacksModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getFeedbacks: function (callback) {
            console.log("this was called from FeedbacksModule");

            $.ajax({
                type: "GET",
                dataType: "json",
                url: "https://nandosojosiahm.azurewebsites.net/api/feedbacks",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }
            });
        }
    };
}());