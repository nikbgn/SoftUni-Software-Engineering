function addItem() {
  let listOfItems = document.getElementById("items");
  let inputBox = document.getElementById("newItemText");
  let newItem = document.createElement("li");
  let deleteOption = document.createElement("a");
  newItem.textContent = inputBox.value;
  deleteOption.textContent = "[Delete]";
  deleteOption.setAttribute("href", "#");
  deleteOption.addEventListener("click", function (e) {
    this.parentElement.remove();
  });
  newItem.appendChild(deleteOption);
  listOfItems.appendChild(newItem);
  inputBox.value = "";
}
