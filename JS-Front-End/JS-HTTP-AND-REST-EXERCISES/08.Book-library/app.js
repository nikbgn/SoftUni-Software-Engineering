function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/collections/books/";

  //Buttons
  const loadBooksButton = document.getElementById("loadBooks");
  const submitButton = document.querySelector("#form button");

  //Input fields
  const title = document.querySelector('input[name="title"]');
  const author = document.querySelector('input[name="author"]');

  //Event listeners
  loadBooksButton.addEventListener("click", loadBooks);
  submitButton.addEventListener("click", submitBook);

  let editId = "";

  async function loadBooks() {
    try {
      const booksResponse = await fetch(BASE_URL);
      const books = await booksResponse.json();

      const tbody = document.getElementsByTagName("tbody")[0];
      tbody.innerHTML = "";

      for (const [id, bookData] of Object.entries(books)) {
        const newTableRow = tableRowGenerator(id, bookData);
        tbody.appendChild(newTableRow);
      }
      clearInputBoxes();
    } catch (error) {
      console.error(error);
    }
  }

  function tableRowGenerator(id, data) {
    const tr = document.createElement("tr");
    tr.innerHTML = `<td>${data.title}</td>
    <td>${data.author}</td>`;

    const td = document.createElement("td");
    const editBtn = document.createElement("button");
    editBtn.textContent = "Edit";
    const deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";

    editBtn.addEventListener("click", editHandler);
    deleteBtn.addEventListener("click", deleteHandler);
    editBtn.id = id;
    deleteBtn.id = id;
    td.appendChild(editBtn);
    td.appendChild(deleteBtn);
    tr.appendChild(td);

    return tr;
  }

  async function submitBook(options) {
    const formText = document.querySelector("#form h3");
    const newBook = {
      author: author.value,
      title: title.value,
    };

    let headers = {
      method: "POST",
      body: JSON.stringify(newBook),
    };
    //Verify fields not empty!
    if (author.value && title.value) {
      if (formText.textContent === "FORM") {
        await fetch(BASE_URL, headers);
        loadBooks();
      } else {
        headers.method = "PUT";
        await fetch(BASE_URL + editId, headers);
        loadBooks();
      }
    }

    formText.textContent = "FORM";
  }
  async function editHandler() {
    try {
      const formText = document.querySelector("#form h3");
      const getBooksResponse = await fetch(BASE_URL);
      const books = await getBooksResponse.json();
      const book = books[this.id];
      author.value = book.author;
      title.value = book.title;
      formText.textContent = "Edit Form";
      editId = this.id;
    } catch (error) {
      console.error(error);
    }
  }
  async function deleteHandler() {
    let headers = {
      method: "DELETE",
    };
    await fetch(BASE_URL + this.id, headers);
    clearInputBoxes();
    loadBooks();
  }

  function clearInputBoxes() {
    title.value = "";
    author.value = "";
  }
}

attachEvents();
