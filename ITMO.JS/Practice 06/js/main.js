function changeStyle() {
    let textElement = document.getElementById("text");
    textElement.style.color = "red";
    textElement.style.fontSize = "20px";
    textElement.style.textDecoration = "underline";
    textElement.style.fontWeight = "bold";
}

let link = document.getElementById("link");
link.addEventListener("mouseover", changeStyle);
