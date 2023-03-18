function solve(text) {
  let text_split = text.split(" ");

  const word_is_tag = function (word) {
    if(word[0] !== "#" || word.length === 1) return false;
    if(string_is_only_english_letters(word)) return true;
    return false;
  };

  const string_is_only_english_letters = function (word) {
    let word_to_check = word.substring(1).toLowerCase();
    //97 122
    for(let i = 0; i < word_to_check.length; i++){
        let current_ascii_number = word_to_check.charCodeAt(i);
        if(!(current_ascii_number >= 97 && current_ascii_number <= 122)){
            return false;
        }
    }
    return true;
  }

  for (let i = 0; i < text_split.length; i++) {
    let current_word = text_split[i];
    if (word_is_tag(current_word)) console.log(current_word.substring(1));
  }
}

console.log(solve('Nowadays everyone uses # to tag a #special word in #socialMedia'));
