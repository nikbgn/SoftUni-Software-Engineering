function phone_book(information_arr) {
  const phone_book = {};
  information_arr.forEach((item) => {
    let data = item.split(" ");
    phone_book[data[0]] = data[1];
  });

  for (const key of Object.keys(phone_book)) {
    console.log(`${key} -> ${phone_book[key]}`);
  }
}
