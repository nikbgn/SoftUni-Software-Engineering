async function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/collections/students";
  const form = document.querySelector("#form");
  const tableBody = document.querySelector("tbody");
  const submitBtn = document.getElementById("submit");
  const firstNameInput = document.querySelector("#form input[name=firstName]");
  const lastNameInput = document.querySelector("#form input[name=lastName]");
  const facultyNumberInput = document.querySelector(
    "#form input[name=facultyNumber]"
  );
  const gradeInput = document.querySelector("#form input[name=grade]");

  const studentsRes = await fetch(BASE_URL);
  if (studentsRes.ok) {
    const students = await studentsRes.json();

    Object.values(students).forEach((s) => {
      studentBuilder(s);
    });
  }

  submitBtn.addEventListener("click", async (e) => {
    e.preventDefault();

    if (
      !firstNameInput.value ||
      !lastNameInput.value ||
      !facultyNumberInput.value ||
      !gradeInput.value
    ) {
      return;
    }

    let firstName = firstNameInput.value;
    let lastName = lastNameInput.value;
    let facultyNumber = facultyNumberInput.value;
    let grade = gradeInput.value;

    const student = { firstName, lastName, facultyNumber, grade };

    await fetch(BASE_URL, {
      method: "POST",
      body: JSON.stringify(student),
    });

    studentBuilder(student);
    clearInputs();
  });

  function studentBuilder(studentDataObj) {
    const tr = document.createElement("tr");
    tr.innerHTML = `
      <td>${studentDataObj.firstName}</td>
      <td>${studentDataObj.lastName}</td>
      <td>${studentDataObj.facultyNumber}</td>
      <td>${studentDataObj.grade}</td>`;
    tableBody.appendChild(tr);
  }

  function clearInputs() {
    firstNameInput.value = "";
    lastNameInput.value = "";
    facultyNumberInput.value = "";
    gradeInput.value = "";
  }
}

attachEvents();
