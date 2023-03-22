function address_book(addresses_info) {
  const address_book = {};
  addresses_info.forEach((address_info_pair) => {
    let information = address_info_pair.split(':');
    let person_name = information[0];
    let person_address = information[1];
    address_book[person_name] = person_address;
  });

  for (const key of Object.keys(address_book).sort()){
    console.log(`${key} -> ${address_book[key]}`);
  }
}
