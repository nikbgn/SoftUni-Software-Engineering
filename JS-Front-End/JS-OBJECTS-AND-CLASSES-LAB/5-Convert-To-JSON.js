function convert_to_json(name,lastName,hairColor) {
    let person_info = {
        name,
        lastName,
        hairColor
    };
    return JSON.stringify(person_info);
}