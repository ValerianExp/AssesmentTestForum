import { useRef, useState, Component, useEffect } from "react";
import "./postPage.css";
import { useNavigate } from "react-router-dom";

function PostPage() {
  const [inputTitle, setinputTitle] = useState("Tittle");
  const inputTitleRef = useRef();
  const [inputCategory, setinputCategory] = useState("Category");
  const inputCategoryRef = useRef();
  const [inputPost, setinputPost] = useState("Post");
  const inputPostRef = useRef();
  const [inputImagen, setinputImagen] = useState("Imagen");
  const inputImagenRef = useRef();

  const [data, setData] = useState();
  const [isValid, setIsValid] = useState(false);
  useEffect(() => {
    setIsValid(data ? true : false);
  }, [data]);

  return (
    <div className="row">
      <table
        id="newtab"
        className="table table-striped table-bordered table-responsive"
      >
        <tbody>
          <tr>
            <td>
              <h3 className="h5 mb-0">
                <div className="Title">
                  <label htmlFor="Tittle">
                    <span className="req"></span>
                  </label>
                  <input
                    type="text"
                    id="titlepost"
                    placeholder="Title*"
                    ref={inputTitleRef}
                    required
                    autocomplete="off"
                  />
                </div>
              </h3>
              <div className="relative">
                <select className="categ">
                  <option value="" selected disable hidden>
                    ---Select Category---
                  </option>
                  <option value="Question">Question</option>
                  <option value="Suggestion">Suggestion</option>
                  <option value="Clarification">Clarification</option>
                  {!isValid && <p>You must choose a category</p>}
                </select>
              </div>
              <div className="Post">
                <label htmlFor="Post">
                  <span className="req"></span>
                </label>
                <input
                  type="text"
                  id="post"
                  placeholder="Body"
                  ref={inputTitleRef}
                  required
                  autocomplete="off"
                />
              </div>
            </td>
          </tr>
        </tbody>
        <div className="switch-button">
          <input className="switch-button-checkbox" type="checkbox"></input>
          <label className="switch-button-label" for="">
            <span className="switch-button-label-span">Private</span>
          </label>
        </div>
        <button disabled={!isValid} id="postit" className="bttns">
          POST IT
        </button>
      </table>
    </div>
  );
}
export default PostPage;
