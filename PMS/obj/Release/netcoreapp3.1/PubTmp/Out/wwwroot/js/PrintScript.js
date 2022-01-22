////function printtag(tagid) {
////    var hashid = "#" + tagid;
////    var tagname = $(hashid).prop("tagName").toLowerCe();

////    var attributes = "";
////    var attrs = document.getElementById(tagid).aributes;

////    $.each(attrs, function (i, elem) {
////        attributes += " " + elem.name + " ='" + elem.value + "' ";
////    })
////    var divToPrint = $(hashid).html();
////    var head = "<html><head>" + $("head").html() + "</head>";
////    var allcontent = head + "<body  onload='window.print()' >" + "<" + tagname + attributes + ">" + divToPrint + "</" + tagname + ">" + "</body></html>";
////    var newWin = window.open('', 'Print-Window');
////    //newWin.document.open();
////    newWin.document.write(allcontent);
////    setTimeout(function () { newWin.print(); }, 300);
////    newWin.document.close();
////    //

  
////    //newWin.onfocus = function () { setTimeout(functiowindow.close();

////    return true;
////}

//function printHTML(htmlString) {
//    var newIframe = document.createElement('iframe');
//    newIframe.width = '1px';
//    newIframe.height = '1px';
//    newIframe.src = 'about:blank';

//    // for IE wait for the IFrame to load so we can access contentWindow.document.body
//    newIframe.onload = function () {
//        var script_tag = newIframe.contentWindow.document.createElement("script");
//        script_tag.type = "text/javascript";
//        var script = newIframe.contentWindow.document.createTextNode('function Print(){ window.focus(); window.print(); }');
//        script_tag.appendChild(script);

//        newIframe.contentWindow.document.body.innerHTML = htmlString;
//        newIframe.contentWindow.document.body.appendChild(script_tag);

//        // for chrome, a timeout for loading large amounts of content
//        setTimeout(function () {
//            newIframe.contentWindow.Print();
//            newIframe.contentWindow.document.body.removeChild(script_tag);
//            newIframe.parentElement.removeChild(newIframe);
//        }, 200);
//    };
//    document.body.appendChild(newIframe);
//}

    function printDiv(elementId) {
        let printElement = document.getElementById(elementId);
        var printWindow = window.open('?', '_top');
        printWindow.document.write(document.documentElement.innerHTML);
        setTimeout(() => { // Needed for large documents
            printWindow.document.body.style.margin = '0 0';
            printWindow.document.body.innerHTML = printElement.outerHTML;
            printWindow.document.close(); // necessary for IE >= 10
            printWindow.focus(); // necessary for IE >= 10*/
            printWindow.print();
            printWindow.close();
        }, 1000)
    }

 

function printSaveTrigger(elementIdTriggered) {
    let printElementsave = document.getElementById(elementIdTriggered);
    var printWindowsave = window.open('', 'PRINT');
    printWindowsave.document.write(document.documentElement.innerHTML);
    setTimeout(() => { // Needed for large documents
        printWindowsave.document.body.style.margin = '0 0';
        printWindowsave.document.body.innerHTML = printElementsave.outerHTML;
        printWindowsave.document.close(); // necessary for IE >= 10
        printWindowsave.focus(); // necessary for IE >= 10*/
        printWindowsave.print();
        printWindowsave.close();
    }, 1000)
}