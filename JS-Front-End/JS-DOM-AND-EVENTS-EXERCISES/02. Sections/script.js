function create(words) {
  let contentDiv = document.getElementById("content");
  words.forEach((section) => {
    const sectionDiv = document.createElement("div");
    const sectionParagraph = document.createElement("p");
    sectionParagraph.textContent = section;
    sectionParagraph.style.display = "none";
    sectionDiv.appendChild(sectionParagraph);
    sectionDiv.addEventListener("click", () => {
      sectionParagraph.style.display = "block";
    });
    
    contentDiv.appendChild(sectionDiv);
  });
}
