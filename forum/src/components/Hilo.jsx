import "./Hilo.css";
import postPage from "./postPage";
import React, { useRef, useState, Component } from "react";
import { useNavigate } from "react-router-dom";

function Hilo() {
  const navigate = useNavigate();
  //   const goToThreadPost = () => {
  //     navigate;
  //   };
  return (
    <div className="row">
      <table className="table table-striped table-bordered table-responsive">
        <tbody>
          <tr>
            <td>
              <h3 className="h5 mb-0">
                <div className="Title">
                  <a className="Name">Titulo del Post</a>
                </div>
              </h3>
              <p className="mb-0">Descrición del post</p>
            </td>
          </tr>
        </tbody>
        <button
          id="creaPost"
          className="bttns"
          onClick={() => navigate("/thread/post")}
        >
          CREATE POST
        </button>
      </table>
    </div>
  );
}
export default Hilo;
