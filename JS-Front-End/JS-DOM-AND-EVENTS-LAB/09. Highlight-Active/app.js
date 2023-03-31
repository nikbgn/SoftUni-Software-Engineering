function focused() {
  let inputs = document.getElementsByTagName("input");

  for (element of inputs) {
    element.addEventListener("focus", (e) => {
      e.originalTarget.parentElement.classList.add("focused");
    });
    element.addEventListener("blur", (e) => {
      e.originalTarget.parentElement.classList.remove("focused");
    });
  }
}
