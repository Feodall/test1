import {Header} from './components/Header'
import {Sign} from './components/Sign'
import {Users} from './components/Users'
import {Competences} from './components/Competences'
import {Routes, Route} from 'react-router-dom'

const App = () => {
  return(
    <div className = "container">
      <Header/>
      <Routes>
        <Route path="/sign" element={<Sign />} />
        <Route path="/users" element={<Users />} />
        <Route path="/auth" element={<Competences />} />
        <Route path="/" element={<Competences />} />
      </Routes>
    </div>
  )
}

export default App;