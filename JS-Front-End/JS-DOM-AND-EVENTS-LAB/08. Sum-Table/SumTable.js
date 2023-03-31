function sumTable() {
  let trElements = Array.from(document.getElementsByTagName("tr"));
  let finalPriceTr = trElements[trElements.length - 1];
  trElements = trElements.slice(1, trElements.length - 1);
  let sum = 0;
  trElements.forEach((product) => {
    let productPrice = Number(product.children[1].textContent);
    sum += productPrice;
  });
  finalPriceTr.children[1].textContent = sum;
}
