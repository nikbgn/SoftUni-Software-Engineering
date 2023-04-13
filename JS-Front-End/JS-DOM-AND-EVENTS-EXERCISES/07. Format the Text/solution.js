function solve() {
  const textArea = document.getElementById("input");
  const output = document.getElementById("output");
  let sentences = Array.from(
    textArea.value.split(".").map((sentence) => sentence.trim())
  );

  sentences.pop();

  while (sentences.length > 0) {
    let newParagraph = document.createElement("p");
    let getSentences = sentences.slice(0, 3);
    newParagraph.textContent = getSentences.join(".") + ".";
    for (let i = 0; i < 3; i++) {
      sentences.shift();
    }

    output.appendChild(newParagraph);
  }
}
