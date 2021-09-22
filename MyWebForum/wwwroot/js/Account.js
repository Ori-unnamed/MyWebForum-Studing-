function js_login() {
    layer.open({
        type: 1,
        title: "登录",
        area: ['500px', '300px'],
        shadeClose: true,
        content: $('#login')
    });

}
function js_regin() {
    layer.open({
        type: 1,
        title: "注册",
        area: ['500px', '300px'],
        shadeClose: true,
        content: $('#regin')
    });

}
$(function () {
    $("#regin_conf").click(function () {
        var tag = {};
        tag["UserName"] = $("#username_reg").val();
        tag["PassWord"] = $("#userpwd_reg").val();
        $.ajax({
            type: "post",
            dataType: "text",
            url: "/Account/Reg_in",
            contentType: "application/json;charset=UTF-8",
            data: JSON.stringify(tag),
            beforeSend: function () {
                if (tag["PassWord"] != $("#userpwd_conf_reg").val()) {
                    alert("密码不一致");
                    return false;
                }
            },
            success: function (data) {
                alert(data);
                layer.close(layer.index);
            },
            error: function (data) {
                alert(data);
            }
        });
    });
    $("#login_conf").click(function () {
        var tag = {};
        tag["UserName"] = $("#username_log").val();
        tag["PassWord"] = $("#userpwd_log").val();
        $.ajax({
            type: "post",
            dataType: "text",
            url: "/Account/Log_in",
            contentType: "application/json;charset=UTF-8",
            data: JSON.stringify(tag),
            success: function (data) {
                alert(data);
                layer.close(layer.index);
                location.reload(location.href);
            },
            error: function (data) {
                alert(data);
            }
        });
    });
});