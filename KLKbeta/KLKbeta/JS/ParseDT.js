$(function parse(){
    alert($("td").css("background-color"));
    $("td").css("background-color", "blue");
    var dataTable = this.getElementsByName("FactTable");
    var tdOfTable = dataTable.length;
    alert(tdOfTable)
});