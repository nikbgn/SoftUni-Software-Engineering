function employees(input) {
  let employees = [];
  input.forEach((person) => {
    let employee = {};
    employee.Name = person;
    employee["Personal Number"] = person.length;
    employee.printInfo = () => {
      console.log(
        `Name: ${employee.Name} -- Personal Number: ${employee.Name.length}`
      );
    };
    employees.push(employee);
  });

  employees.forEach((emp) => {
    emp.printInfo();
  });
}
