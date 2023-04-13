function solve() {
  document.querySelector("#searchBtn").addEventListener("click", onClick);
  const tableBody = document.getElementsByTagName("tbody")[0];

  function onClick() {
    const tBodyChildren = Array.from(tableBody.children);
    const searchingFor = document.getElementById("searchField");
    tBodyChildren.forEach((child) => {
      child.classList.remove("select");
      let rowText = child.innerText.trim();
      if (rowText.includes(searchingFor.value)) {
        child.classList.add("select");
      }
    });

    searchingFor.value = "";
  }
}
