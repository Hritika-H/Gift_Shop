<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">  
        body {  
            margin: 0;  
            background: #e6e6e6;  
        }  
        .showSlide {  
            display: none  
        }  
            .showSlide img {  
                width: 100%;  
            }  
        .slidercontainer {  
            max-width: 800px;  
            position: relative;  
            margin: auto;  
        }  
        .left, .right {  
            cursor: pointer;  
            position: absolute;  
            top: 50%;  
            width: auto;  
            padding: 16px;  
            margin-top: -22px;  
            color: white;  
            font-weight: bold;  
            font-size: 18px;  
            transition: 0.6s ease;  
            border-radius: 0 3px 3px 0;  
        }  
        .right {  
            right: 0;  
            border-radius: 3px 0 0 3px;  
        }  
            .left:hover, .right:hover {  
                background-color: rgba(115, 115, 115, 0.8);  
            }  
        .content {  
            color: #b262f1;  
            font-size: 30px;  
            padding: 8px 12px;  
            position: absolute;  
            top: 10px;  
            width: 100%;  
            text-align: center;  
        }  
        .active {  
            background-color: #717171;  
        }  
        /* Fading animation */  
        .fade {  
            -webkit-animation-name: fade;  
            -webkit-animation-duration: 1.5s;  
            animation-name: fade;  
            animation-duration: 1.5s;  
        }  
        @-webkit-keyframes fade {  
            from {  
                opacity: .4  
            }  
            to {  
                opacity: 1  
            }  
        }  
  
        @keyframes fade {  
            from {  
                opacity: .4  
            }  
            to {  
                opacity: 1  
            }  
        }  
    </style>  
      
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="slidercontainer">  
        <div class="showSlide fade">  
            <img src="himages/giftbox2.jpg" /> 
            <div class="content">Find the perfect gift</div>  
        </div>  
        <div class="showSlide fade">  
            <img src="himages/fmg1.jpeg" />
            <div class="content">Special gifts</div>  
        </div>  
  
        <div class="showSlide fade">  
            <img src="himages/teddy.jpg" />
            <div class="content">Gifts for all ages</div>  
        </div>  
        <div class="showSlide fade">  
            <img src="himages/christmasceleb.jpeg" />
            <div class="content">Gifts for occasions</div>  
        </div>  
        <!-- Navigation arrows -->  
        <a class="left" onclick="nextSlide(-1)">❮</a>  
        <a class="right" onclick="nextSlide(1)">❯</a>  
    </div>  
  
    <script type="text/javascript">  
        var slide_index = 1;  
        displaySlides(slide_index);  
  
        function nextSlide(n) {  
            displaySlides(slide_index += n);  
        }  
  
        function currentSlide(n) {  
            displaySlides(slide_index = n);  
        }  
  
        function displaySlides(n) {  
            var i;  
            var slides = document.getElementsByClassName("showSlide");  
            if (n > slides.length) { slide_index = 1 }  
            if (n < 1) { slide_index = slides.length }  
            for (i = 0; i < slides.length; i++) {  
                slides[i].style.display = "none";  
            }  
            slides[slide_index - 1].style.display = "block";  
        }  
    </script>  
   
   

</asp:Content>

