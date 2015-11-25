// This event triggers on page load
document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded and ready to go!");
    loadSpecials();
    loadFeedbacks();
});

function loadSpecials() {
    SpecialsModule.getSpecials(setupSpecialsTable);
}

function loadFeedbacks() {
    FeedbacksModule.getFeedbacks(setupFeedbacksTable);
}

function setupSpecialsTable(specialsList) {

    // We need a reference to the div/table that we are going to chuck our data into
    var specialsTable = document.getElementById("specialsList");
    console.log(specialsList);

    for (i = 0; i < specialsList.length; i++) {
        var row = document.createElement("tr");

        var dishNameCol = document.createElement("td")
        dishNameCol.innerHTML = specialsList[i].SpecialName;
        row.appendChild(dishNameCol);

        var dishPriceCol = document.createElement("td")
        dishPriceCol.innerHTML = specialsList[i].SpecialPrice;
        row.appendChild(dishPriceCol);

        var descriptionCol = document.createElement("td")
        descriptionCol.innerHTML = specialsList[i].SpecialDescription;
        row.appendChild(descriptionCol);

        specialsTable.appendChild(row);
    }

}

function setupFeedbacksTable(feedbacksList) {

    // We need a reference to the div/table that we are going to chuck our data into
    var feedbacksTable = document.getElementById("feedbacksList");
    console.log(feedbacksList);

    for (i = 0; i < feedbacksList.length; i++) {
        var usernameRow = document.createElement("tr")
        usernameRow.innerHTML = feedbacksList[i].CommentorName;
        feedbacksTable.appendChild(usernameRow);

        var commentRow = document.createElement("tr")
        commentRow.innerHTML = feedbacksList[i].Comment;
        feedbacksTable.appendChild(commentRow);
    }

}