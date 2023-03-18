function solve(text) {
    return text.split(/(?=[A-Z])/g).join(', ');
}
