function Zoomin(positionCounter) {
    var ElementZoomin = $('#ElementTR');
    ElementZoomin.show();
    var ElementId = "#E_" + positionCounter;
    var ElementIdPlain = "E_" + positionCounter;
    var ElementBackgroundColor = document.getElementById(ElementIdPlain).getAttribute('class');

    
    $(ElementId).addClass('selectedcell');
    
    document.getElementById('ElementTR').setAttribute('class', ElementBackgroundColor);
    var ElementInfo = $(ElementId).closest('td');
    var number = ElementInfo.find('div:eq(0)').text();
    var symbol = ElementInfo.find('div:eq(1)').text();
    var name = ElementInfo.find('div:eq(2)').text();
    $('#NumberZoomin').html(number);
    $('#SymbolZoomin').html(symbol);
    $('#NameZoomin').html(name);
}
function Zoomout(positionCounter) {
    var ElementId = "#E_" + positionCounter;
    $(ElementId).removeClass('selectedcell');
    $('#ElementTR').hide();
}