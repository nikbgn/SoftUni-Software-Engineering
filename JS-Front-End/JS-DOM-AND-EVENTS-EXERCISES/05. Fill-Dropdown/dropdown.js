function addItem() {
  const newItemText = document.getElementById("newItemText");
  const newItemValue = document.getElementById("newItemValue");
  const select = document.getElementById("menu");
  const newOption = document.createElement("option");
  newOption.textContent = newItemText.value;
  newOption.value = newItemValue.value;
  select.appendChild(newOption);
  newItemText.value = "";
  newItemValue.value = "";
}
