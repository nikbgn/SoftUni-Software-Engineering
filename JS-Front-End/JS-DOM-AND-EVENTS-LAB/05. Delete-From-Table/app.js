function deleteByEmail() {
  let table_body = document.getElementsByTagName("tbody");
  let rows = Array.from(table_body[0].rows);
  let email_needed = document.getElementsByTagName('input')[0].value.trim();
  rows.forEach((r) => {
    let current_row_email = r.childNodes[3].innerText;
    if(current_row_email === email_needed){
        table_body[0].removeChild(r);
        document.getElementById('result').textContent = "Deleted.";
    }else{
        document.getElementById('result').textContent = "Not found.";
    }
  });
}
