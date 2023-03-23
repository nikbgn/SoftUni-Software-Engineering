function inventory(input) {
  class Hero {
    constructor(heroName, heroLevel, heroItems) {
      this.Hero = heroName;
      this.level = heroLevel;
      this.Items = heroItems;
    }

    logHeroInfo() {
      console.log(
        `Hero: ${this.Hero}\nlevel => ${this.level}\nitems => ${this.Items}`
      );
    }
  }
  let heroes = [];

  input.forEach((hero_input) => {
    [name, level, ...items] = hero_input.split(" / ");
    let new_hero = new Hero(name, level, items);
    heroes.push(new_hero);
  });

  heroes
    .sort((h1, h2) => {
      return h1.level - h2.level;
    })
    .forEach((h) => h.logHeroInfo());
}
