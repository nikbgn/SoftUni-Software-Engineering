function solve() {
  const tableBody = document.querySelector("tbody");
  const generateButton = document.getElementsByTagName("button")[0];
  const buyButton = document.getElementsByTagName("button")[1];
  generateButton.addEventListener("click", handleGenerate);
  buyButton.addEventListener("click", handleBuy);

  function handleGenerate() {
    const textAreaJSON = document.getElementsByTagName("textarea")[0];
    let items = JSON.parse(textAreaJSON.value);
    for (const item of items) {
      let newItem = trCreator(item.img, item.name, item.price, item.decFactor);
      tableBody.appendChild(newItem);
    }
  }

  function handleBuy() {
    const allCheckedElements = Array.from(
      document.querySelectorAll('input[type="checkbox"]:checked')
    ).map((e) => e.parentElement.parentElement);
    let outputData = { names: [], prices: [], decFactors: [] };
    allCheckedElements.forEach((element) => {
      let children = Array.from(element.children);
      outputData["names"].push(children[1].textContent);
      outputData["prices"].push(Number(children[2].textContent));
      outputData["decFactors"].push(Number(children[3].textContent));
    });
    let outputTextArea = document.getElementsByTagName("textarea")[1];
    let output = "";
    let pricesSum = arraySumGetter(outputData["prices"]);
    let decFactorSum = arraySumGetter(outputData["decFactors"]);

    output += `Bought furniture: ${outputData["names"].join(", ")}\n`;
    output += `Total price: ${pricesSum.toFixed(2)}\n`;
    output += `Average decoration factor: ${
      decFactorSum / outputData["decFactors"].length
    }`;
    outputTextArea.value = output;
  }

  function trCreator(imgSrc, title, price, decFactor) {
    let tr = document.createElement("tr");
    if (imgSrc) {
      let td = document.createElement("td");
      let image = document.createElement("img");
      image.setAttribute("src", imgSrc);
      td.innerHTML = "";
      td.appendChild(image);
      tr.appendChild(td);
    }
    if (title) {
      let td = document.createElement("td");
      let itemTitle = document.createElement("p");
      itemTitle.textContent = title;
      td.innerHTML = "";
      td.appendChild(itemTitle);
      tr.appendChild(td);
    }
    if (price) {
      let td = document.createElement("td");
      let itemPrice = document.createElement("p");
      itemPrice.textContent = price;
      td.innerHTML = "";
      td.appendChild(itemPrice);
      tr.appendChild(td);
    }
    if (decFactor) {
      let td = document.createElement("td");
      let itemDecFactor = document.createElement("p");
      itemDecFactor.textContent = decFactor;
      td.innerHTML = "";
      td.appendChild(itemDecFactor);
      tr.appendChild(td);
    }
    let td = document.createElement("td");
    let checkBox = document.createElement("input");
    checkBox.setAttribute("type", "checkbox");
    td.innerHTML = "";
    td.appendChild(checkBox);
    tr.appendChild(td);

    return tr;
  }

  function arraySumGetter(arr) {
    let sum = 0;
    arr.forEach((e) => (sum += Number(e)));
    return sum;
  }
}
