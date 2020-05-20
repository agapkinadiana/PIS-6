<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="lab2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        var ws;
        window.onload = function () {
            if (Modernizr.websockets) {
                WriteMessage('support', ' да ');
                ta = document.getElementById('ta');
                bstart = document.getElementById('bstart');
                bstop = document.getElementById('bstop');
                bstart.disabled = false;
                bstop.disabled = true;
            }
        }

        function WriteMessage(idspan, txt) {
            var span = document.getElementById(idspan);
            span.innerHTML = txt;
        }

        function exe_start() {
            if (ws == null) {
                ws = new WebSocket('ws://localhost:50722/yyy.websocket');
                ws.onopen = function () { ws.send('Connecting') }
                ws.onclose = function (s) { console.log('onclose' + s); }
                ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
                bstart.disabled = true;
                bstop.disabled = false;
            }
        }

        function exe_stop() {
            ws.close(3001, ' stopapplication');
            ws = null;
            bstart.disabled = false;
            bstop.disabled = true;
        }
    </script>
    <h1>Web Sockets</h1>
    <span>Web sockets поддерживается?</span> <span id="support"></span>
    <br/>
            <section style="width: 215px; border: solid">
                <div style="margin: 5px 5px 5px 5px">
                    <input id="bstart" type="button" value="Старт" onclick="exe_start()" style="width: 100px" />
                    <input id="bstop" type="button" value="Стоп" onclick="exe_stop()" style="width: 100px" />
                    <textarea id="ta" rows="20" cols="25" style="text-align: center"; readonly>
                        </textarea>
                </div>
            </section>
</asp:Content>
