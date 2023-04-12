function toggle() {
  const button = document.getElementsByClassName("button")[0];
  const information = document.getElementById("extra");

  if (button.textContent.toLowerCase() === "more") {
    information.style.display = "block";
    button.textContent = "Less";
  } else {
    information.style.display = "none";
    button.textContent = "More";
  }
}
