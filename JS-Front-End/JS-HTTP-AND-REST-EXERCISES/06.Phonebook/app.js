function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/phonebook/";
  const phonebookUl = document.getElementById("phonebook");
  const personInput = document.getElementById("person");
  const phoneInput = document.getElementById("phone");
  const loadButton = document.getElementById("btnLoad");
  const createButton = document.getElementById("btnCreate");

  loadButton.addEventListener("click", loadHandler);
  createButton.addEventListener("click", postHandler);

  async function loadHandler() {
    phonebookUl.innerHTML = "";
    clearInputs();
    const phonebookResponse = await fetch(BASE_URL);
    const phonebook = await phonebookResponse.json();

    for (const entry of Object.values(phonebook)) {
      const li = document.createElement("li");
      li.textContent = `${entry.person}: ${entry.phone}`;
      const deleteButton = document.createElement("button");
      deleteButton.textContent = "Delete";
      deleteButton.setAttribute("id", entry._id);
      deleteButton.addEventListener("click", deleteHandler);
      li.appendChild(deleteButton);
      phonebookUl.appendChild(li);
    }
  }

  async function deleteHandler() {
    await fetch(BASE_URL + this.id, { method: "DELETE" });
    loadHandler();
  }

  async function postHandler() {
    const headers = {
      method: "POST",
      body: JSON.stringify({
        person: personInput.value,
        phone: phoneInput.value,
      }),
    };

    await fetch(BASE_URL, headers);
    loadHandler();
  }

  function clearInputs() {
    personInput.value = "";
    phoneInput.value = "";
  }
}

attachEvents();
