window.RichTextEditor = {
    
    focus: function () {
        var rteInstance = document.querySelector('.e-richtexteditor .e-content').lastElementChild;
        // element.focusIn();
        // To find last direct childnode 
      //  var editEleLastNode = document.querySelector('.e-richtexteditor .e-content').lastChild;

        // Find the all text node from editor element 
        //var textNodes = getTextNodesUnder(document, editEleLastNode);
        rteInstance.scrollIntoView();
    }

}