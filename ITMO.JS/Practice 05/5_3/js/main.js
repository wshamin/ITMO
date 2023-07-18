function createTable() {
    let table = document.getElementById("multiple");
    for(let i = 1; i <= 10; i++) {
        let row = document.createElement("tr");
        for(let j = 1; j <= 10; j++) {
            let cell = document.createElement("td");
            cell.innerHTML = i * j;
            row.appendChild(cell);
        }
        table.appendChild(row);
    }
}

createTable();

favoriteMovies = ["Карты, деньги, два ствола", "Револьвер", "Криминальное чтиво", "Омерзительная восьмерка", "Гарри Поттер и узник Азкабана"];

console.log(favoriteMovies);

favoriteMovies.push("Довод");
console.log(favoriteMovies);

favoriteMovies.unshift("Вавилон");
console.log(favoriteMovies);

favoriteMovies.pop();
console.log(favoriteMovies);

let babylon = favoriteMovies.shift();
console.log(babylon);