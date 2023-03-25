function addItem() {
    let new_item_input = document.getElementById('newItemText').value;
    let list_of_items = document.getElementById('items');

    let new_item = document.createElement("li");
    new_item.textContent = new_item_input;
    list_of_items.appendChild(new_item);
}