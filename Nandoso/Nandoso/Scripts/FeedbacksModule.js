var FeedbacksModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getFeedbacks: function (callback) {

            var xhttp = new XMLHttpRequest();

            //This gets triggered when the state of the xhttp object changes
            xhttp.onreadystatechange = function () {
                // 4 - repsonse is ready, 200 success code
                if (xhttp.readyState == 4 && xhttp.status == 200) {
                    loadFeedbacks();
                }
            }

            // Build up our request and send it - true for async
            xhttp.open("GET", "https://nandosojosiahm.azurewebsites.net/api/feedbacks", true);
            xhttp.setRequestHeader("Content-type", "application/json");
            xhttp.send(null);

            // Parse and send the studentlist data back to index.js
            function loadedStudents() {
                var feedbacksList = JSON.parse(xhttp.responseText);
                callback(feedbacksList);
                return feedbacksList;
            }
        },

        getStudentById: function (id, callback) {

            var xhttp = new XMLHttpRequest();

            xhttp.onreadystatechange = function () {
                if (xhttp.readyState == 4 && xhttp.status == 200) {
                    loadedStudent();
                }
            }

            xhttp.open("GET", "http://msauniversity.azurewebsites.net/api/Students/" + id, true);
            xhttp.setRequestHeader("Content-type", "application/json");

            xhttp.send();

            function loadedStudent() {
                var student = JSON.parse(xhttp.responseText);
                callback(student);
                return student;
            }
        },

        addFeedbacks: function (feedbacks, callback) {
            var xhttp = new XMLHttpRequest();

            xhttp.onreadystatechange = function () {
                if (xhttp.readyState == 4 && xhttp.status == 201) {
                    callback();
                }
            }

            xhttp.open("POST", "https://nandosojosiahm.azurewebsites.net/api/feedbacks", true);
            xhttp.setRequestHeader("Content-type", "application/json");

            xhttp.send(JSON.stringify(feedbacks));

        }
    };
}());