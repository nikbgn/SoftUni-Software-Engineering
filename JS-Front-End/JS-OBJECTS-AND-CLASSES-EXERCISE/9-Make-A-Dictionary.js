function make_a_dictionary(input) {
  const definition_print = (term) => {
    let termName = Object.keys(term);
    let termDefinition = term[termName];
    console.log(`Term: ${termName} => Definition: ${termDefinition}`);
  };

  let terms = [];
  input.forEach((obj) => {
    terms.push(JSON.parse(obj));
  })


  let sorted  = terms.sort((i1,i2) => {
    let [i1Name] = Object.keys(i1);
    let [i2Name] = Object.keys(i2);
    return i1Name.localeCompare(i2Name);
  });

  for(const term of sorted){
    definition_print(term);
  }

}
