import Logo from "./house.png";
import "./App.css";
import Home from "./components/Home";
import { Route, Routes } from "react-router-dom";
import { useNavigate } from "react-router-dom";
import Hilo from "./components/Hilo";
import PostPage from "./components/postPage";

function App() {
  const navigate = useNavigate();
  const goToHome = () => {
    navigate("/");
  };
  return (
    <div className="App">
      <div className="header">
        {<img src={Logo} alt="Logo" className="Logo" onClick={goToHome} />}
        <h1 className="title"> RETRO FORUM</h1>
      </div>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/thread" element={<Hilo />} />
        <Route path="/thread/post" element={<PostPage />} />
      </Routes>
    </div>
  );
}

export default App;
