function store_provision(stock_arr, products_arr) {
  let stock = {};

  for (let i = 0; i < stock_arr.length - 1; i += 2) {
    let item = stock_arr[i];
    let qty = Number(stock_arr[i + 1]);
    stock[item] = qty;
  }


  for (let i = 0; i < products_arr.length - 1; i += 2) {
    let item = products_arr[i];
    let qty = Number(products_arr[i + 1]);

    if(item in stock) stock[item] += qty;
    else stock[item] = qty;
  }

  for(let item in stock){
    console.log(`${item} -> ${stock[item]}`);
  }
}
