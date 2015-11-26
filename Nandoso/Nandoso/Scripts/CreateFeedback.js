document.addEventListener("DOMContentLoaded", function () {
    setupFeedbackSubmit();
    setupReturn();
});

function setupFeedbackSubmit() {

    //Creating student from form parameters

    var form = document.forms.create;
    // Need to add our own custom event for form submission
    form.onsubmit = function (e) {
        // ... and prevent the default action from occuring
        e.preventDefault();

        //Creating student from form parameters
        var newFeedback = {
            // Access the data in the fields with .value 
            name: document.getElementById("Author").value,
            post: document.getElementById("Comment").value
        }

        // Take me back home when done!
        FeedbacksModule.addFeedback(newFeedback, function () {
            window.location.href = "FeedbackPage.html";
        });
    }

};

// Add event listener, cancel button will take you back to home page
function setupReturn() {
    document.getElementById('btncancel').addEventListener('click', function () {
        window.location.href = "FeedbackPage.html";
    });
}