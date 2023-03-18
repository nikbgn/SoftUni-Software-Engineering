function solve(word,text) {
    text = text.toLowerCase();
    word_lower = word.toLowerCase();

    for (const word of text.split(' ')) {
        if(word===word_lower) return word;
    }
    return `${word} not found!`
}
