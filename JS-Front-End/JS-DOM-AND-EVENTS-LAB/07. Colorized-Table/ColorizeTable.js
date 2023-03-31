function colorize() {
  let idx = 0;
  let trElements = Array.from(document.getElementsByTagName("tr"));
  trElements.forEach((currentRow) => {
    if (idx % 2 !== 0) {
      currentRow.style.background = "teal";
    }
    idx++;
  });
}
