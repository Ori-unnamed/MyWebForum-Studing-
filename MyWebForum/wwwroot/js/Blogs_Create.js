
$("textarea#input_blog").keyup(function () {
    var text = document.getElementById("input_blog").value;
    var converter = new showdown.Converter();
    var html = converter.makeHtml(text);
    document.getElementById("output_blog").innerHTML = html;
});
