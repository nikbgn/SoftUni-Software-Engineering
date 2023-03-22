function city_taxes(name, population, treasury) {
  let taxer = {
    name,
    population,
    treasury,
    taxRate: 10,
    collectTaxes: function() {
      this.treasury += this.population * this.taxRate;
    },
    applyGrowth: function (percentage) {
      this.population += Math.round (this.population * percentage / 100);
    },
    applyRecession: function (percentage)  {
      this.treasury -= Math.round(this.treasury * percentage / 100);
    }
  };
  return taxer;
}
