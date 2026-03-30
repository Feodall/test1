import {Header} from './components/Header'
import {Sign} from './components/Sign'
import {Users} from './components/Users'
import {Competences} from './components/Competences'
import {Home} from './components/Home'
import {Footer} from './components/Footer'
import {Routes, Route} from 'react-router-dom'


const App = () => {
  return(
    <div className = "container">
      <Header/>
      <div className="home">
        <Routes>
          <Route path="/sign" element={<Sign />} />
          <Route path="/users" element={<Users />} />
          <Route path="/auth" element={<Competences />} />
          <Route path="/" element={<Home />} />
        </Routes>
      </div>
      <Footer/>

      <Footer/>
    </div>
  )
}

export default App;