function solve(words, template) {
  let words_arr = words.split(", ");
  let template_arr = template.split(' ');
  let idx = 0;
  const get_number_of_stars = function (word) {
    if (word[0] !== "*") return null;
    return word.length;
  };

  template_arr.forEach((word) => {
    let stars_count = get_number_of_stars(word);
    if (stars_count !== null) {
      words_arr.forEach((element) => {
        if (element.length === stars_count) {
          template_arr[idx] = element;
        }
      });
      
    }
    idx++;
  });

  return template_arr.join(" ");
}
