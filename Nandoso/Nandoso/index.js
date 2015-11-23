document.addEventListener("DOMContentLoaded", function () {
    loadSpecials();
});

function loadSpecials() {
    //reference the div/table to display our data in
    var specialsTable = document.getElementById("tblspecialscontent");

    SpecialsModule.getSpecials(function (specialsList) {
        setupSpecialsTable(specialsTable);
    });

    //callback function for data that gets returned from the SpecialsModule
    function setupSpecialsTable(specials) {
        console.log(specials);
        for (i = 0; i < specials.length; i++) {
            //create the rows
            var row = document.createElement('tr');

            //add columns to the row (td/ data cells)
            //might have to change this later to include specials as opposed to having students etc.
            var specialsnamecol = document.createElement('td');
            specialsnamecol.innerHTML = specials[i].name;
            row.appendChild(specialsnamecol);

            var specialspricecol = document.createElement('td');
            specialspricecol.innerHTML = specials[i].surname;
            row.appendChild(specialspricecol);

            var specialsdisplaycol = document.createElement('td');
            specialsdisplaycol.innerHTML = specials[i].name;
            row.appendChild(specialsdisplaycol);

            //append the row to the end of the table
            specialsTable.appendChild(row);
        }
    }

}